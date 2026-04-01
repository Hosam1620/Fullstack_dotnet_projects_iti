using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day_3part_2
{
    struct Password
    {
        string? password;
        public bool SetPassword(string pass)
        {
            password = pass;
            if (IsStrong())
                return true;

            password = null;
            return false;
        }
        public bool IsStrong()
        {
            if (password == null)
                return false;
            string strongPassword = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[@#$%&]).{8,}$";
            return Regex.IsMatch(password!, strongPassword);
        }
        public string GetPasswordStrength()
        {
            if (password == null)
                return "Weak";
            int count = 0;
            if (Regex.IsMatch(password!, "[A-Z]")) count++;
            if (Regex.IsMatch(password!, "[a-z]")) count++;
            if (Regex.IsMatch(password!, "[0-9]")) count++;
            if (Regex.IsMatch(password!, "[@#$%&]")) count++;
            if (password!.Length >= 8) count++;

            if (count <= 2)
                return "Weak";
            else if (count == 4)
                return "Medium";
            else return "Strong";
        }

    }
}
