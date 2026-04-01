using Day_5;

public class BoardMember : Employee
{
    public void Resign()
    {
        OnEmployeeLayOff(new EmployeeLayOffEventArgs
        {
            Cause = LayOffCause.Resigned
        });
    }

    public override void EndOfYearOperation()
    {
        // Board member has no retirement age
    }
}