/* =============================================
   PROCEDURES
============================================= */

DROP PROCEDURE IF EXISTS Exam.Create_Exam;
GO
CREATE PROCEDURE Exam.Create_Exam
    @Exam_Id INT,
    @Crs_Id INT,
    @Year INT,
    @ExamType VARCHAR(50),
    @StartTime DATETIME,
    @EndTime DATETIME
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Exam.Exam WHERE Exam_Id = @Exam_Id)
    BEGIN
        RAISERROR('Exam already exists',16,1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM Academic.Course WHERE Course_Id = @Crs_Id)
    BEGIN
        RAISERROR('Course does not exist',16,1);
        RETURN;
    END

    IF (@EndTime <= @StartTime)
    BEGIN
        RAISERROR('Invalid Time',16,1);
        RETURN;
    END

    INSERT INTO Exam.Exam (Exam_Id, Crs_Id, Year, ExamType, StartTime, EndTime)
    VALUES (@Exam_Id, @Crs_Id, @Year, @ExamType, @StartTime, @EndTime);
END
GO


DROP PROCEDURE IF EXISTS Exam.Get_Exam;
GO
CREATE PROCEDURE Exam.Get_Exam
    @Exam_Id INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Exam.Exam WHERE Exam_Id = @Exam_Id)
    BEGIN
        RAISERROR('Exam not found',16,1);
        RETURN;
    END

    SELECT * FROM Exam.Exam WHERE Exam_Id = @Exam_Id;
END
GO


DROP PROCEDURE IF EXISTS Exam.Update_Exam;
GO
CREATE PROCEDURE Exam.Update_Exam
    @Exam_Id INT,
    @ExamType VARCHAR(50),
    @StartTime DATETIME,
    @EndTime DATETIME
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Exam.Exam WHERE Exam_Id = @Exam_Id)
    BEGIN
        RAISERROR('Exam not found',16,1);
        RETURN;
    END

    IF (@EndTime <= @StartTime)
    BEGIN
        RAISERROR('Invalid Time',16,1);
        RETURN;
    END

    UPDATE Exam.Exam
    SET ExamType = @ExamType,
        StartTime = @StartTime,
        EndTime = @EndTime
    WHERE Exam_Id = @Exam_Id;
END
GO


DROP PROCEDURE IF EXISTS Exam.Delete_Exam;
GO
CREATE PROCEDURE Exam.Delete_Exam
    @Exam_Id INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Exam.Exam WHERE Exam_Id = @Exam_Id)
    BEGIN
        RAISERROR('Exam not found',16,1);
        RETURN;
    END

    DELETE FROM Exam.Exam_Question WHERE Exam_Id = @Exam_Id;
    DELETE FROM Exam.Exam WHERE Exam_Id = @Exam_Id;
END
GO


DROP PROCEDURE IF EXISTS Exam.Add_Question_To_Exam;
GO
CREATE PROCEDURE Exam.Add_Question_To_Exam
    @Exam_Id INT,
    @Q_Id INT,
    @Degree INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Exam.Exam WHERE Exam_Id = @Exam_Id)
    BEGIN
        RAISERROR('Exam not found',16,1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM Exam.Question WHERE Question_ID = @Q_Id)
    BEGIN
        RAISERROR('Question not found',16,1);
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM Exam.Exam_Question WHERE Exam_Id = @Exam_Id AND Q_Id = @Q_Id)
    BEGIN
        RAISERROR('Question already added',16,1);
        RETURN;
    END

    IF @Degree <= 0
    BEGIN
        RAISERROR('Invalid Degree',16,1);
        RETURN;
    END

    DECLARE @CurrentTotal INT;
    DECLARE @MaxDegree INT;

    SELECT @CurrentTotal = ISNULL(SUM(Degree), 0)
    FROM Exam.Exam_Question WHERE Exam_Id = @Exam_Id;

    SELECT @MaxDegree = C.MaxDegree
    FROM Academic.Course C
    JOIN Exam.Exam E ON C.Course_Id = E.Crs_Id
    WHERE E.Exam_Id = @Exam_Id;

    IF (@CurrentTotal + @Degree > @MaxDegree)
    BEGIN
        RAISERROR('Exceeds course max degree',16,1);
        RETURN;
    END

    INSERT INTO Exam.Exam_Question (Exam_Id, Q_Id, Degree)
    VALUES (@Exam_Id, @Q_Id, @Degree);
END
GO


DROP PROCEDURE IF EXISTS Exam.Remove_Question_From_Exam;
GO
CREATE PROCEDURE Exam.Remove_Question_From_Exam
    @Exam_Id INT,
    @Q_Id INT
AS
BEGIN
    IF NOT EXISTS (
        SELECT 1 FROM Exam.Exam_Question 
        WHERE Exam_Id = @Exam_Id AND Q_Id = @Q_Id
    )
    BEGIN
        RAISERROR('Question not found in exam',16,1);
        RETURN;
    END

    DELETE FROM Exam.Exam_Question
    WHERE Exam_Id = @Exam_Id AND Q_Id = @Q_Id;
END
GO


DROP PROCEDURE IF EXISTS Exam.Assign_Exam;
GO
CREATE PROCEDURE Exam.Assign_Exam
    @Exam_Id INT,
    @Intake_Id INT,
    @Branch_Id INT,
    @Track_Id INT
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Exam.Exam WHERE Exam_Id = @Exam_Id)
    BEGIN
        RAISERROR('Exam not found',16,1);
        RETURN;
    END

    IF EXISTS (
        SELECT 1 FROM Exam.Exam_Intake_Branch_Track
        WHERE Exam_Id = @Exam_Id 
        AND Intake_Id = @Intake_Id 
        AND Branch_Id = @Branch_Id 
        AND Track_Id = @Track_Id
    )
    BEGIN
        RAISERROR('Already assigned',16,1);
        RETURN;
    END

    INSERT INTO Exam.Exam_Intake_Branch_Track
    (Exam_Id, Intake_Id, Branch_Id, Track_Id)
    VALUES (@Exam_Id, @Intake_Id, @Branch_Id, @Track_Id);
END
GO

DROP PROCEDURE IF EXISTS Exam.Search_Exam_ByDate;
GO
-- This procedure retrieves exams scheduled on a specific date, 
--including their details and associated course names.
CREATE PROCEDURE Exam.Search_Exam_ByDate
    @Date DATE
AS
BEGIN
    SELECT 
        E.Exam_Id,
        E.ExamType,
        E.StartTime,
        E.EndTime,
        C.Crs_Name
    FROM Exam.Exam E
    JOIN Academic.Course C ON E.Crs_Id = C.Course_Id
    WHERE CAST(E.StartTime AS DATE) = @Date;
END
GO

/* =============================================
   FUNCTIONS
============================================= */

DROP FUNCTION IF EXISTS Exam.Get_Exam_TotalDegree;
GO
CREATE FUNCTION Exam.Get_Exam_TotalDegree (@Exam_Id INT)
RETURNS INT
AS
BEGIN
    DECLARE @Total INT;

    SELECT @Total = ISNULL(SUM(Degree), 0)
    FROM Exam.Exam_Question
    WHERE Exam_Id = @Exam_Id;

    RETURN @Total;
END
GO


DROP FUNCTION IF EXISTS Exam.Get_Exam_Questions;
GO
CREATE FUNCTION Exam.Get_Exam_Questions (@Exam_Id INT)
RETURNS TABLE
AS
RETURN
(
    SELECT Q.Question_ID, Q.Ques_Header, Q.Question_Type, EQ.Degree
    FROM Exam.Exam_Question EQ
    JOIN Exam.Question Q ON EQ.Q_Id = Q.Question_ID
    WHERE EQ.Exam_Id = @Exam_Id
);
GO


/* =============================================
   VIEWS
============================================= */

DROP VIEW IF EXISTS Exam.V_Exam_Details;
GO
CREATE VIEW Exam.V_Exam_Details
AS
SELECT 
    E.Exam_Id,
    E.ExamType,
    E.Year,
    E.StartTime,
    E.EndTime,
    E.TotalTime,
    C.Crs_Name,
    C.MaxDegree
FROM Exam.Exam E
JOIN Academic.Course C ON E.Crs_Id = C.Course_Id;
GO


DROP VIEW IF EXISTS Exam.V_Exam_Questions;
GO
CREATE VIEW Exam.V_Exam_Questions
AS
SELECT 
    E.Exam_Id,
    Q.Question_ID,
    Q.Ques_Header,
    Q.Question_Type,
    EQ.Degree
FROM Exam.Exam E
JOIN Exam.Exam_Question EQ ON E.Exam_Id = EQ.Exam_Id
JOIN Exam.Question Q ON EQ.Q_Id = Q.Question_ID;
GO


/* =============================================
   TRIGGER
============================================= */

DROP TRIGGER IF EXISTS Exam.Check_Total_Degree;
GO
CREATE TRIGGER Exam.Check_Total_Degree
ON Exam.Exam_Question
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM Exam.Exam_Question EQ
        JOIN Exam.Exam E ON EQ.Exam_Id = E.Exam_Id
        JOIN Academic.Course C ON E.Crs_Id = C.Course_Id
        WHERE EQ.Exam_Id IN (SELECT Exam_Id FROM inserted)
        GROUP BY EQ.Exam_Id, C.MaxDegree
        HAVING SUM(EQ.Degree) > C.MaxDegree
    )
    BEGIN
        RAISERROR('Total Degree exceeded!',16,1);
        ROLLBACK;
    END
END
GO