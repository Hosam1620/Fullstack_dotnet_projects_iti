using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    struct PhoneBook
    {
        string[] names;
        long[] numbers;
        int size;

        public PhoneBook()
        {
            names = new string[5];
            numbers = new long[5];
            size = 5;
        }
        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        public int Size { get => size; }
        //Prevent duplicate names
        public bool SetEntry(int index, string name, long number)
        {
            for (int i = 0; i < size; i++)
            {
                if (names[i] == name)
                    return false;
            }
            if (index >= 0 && index < size)
            {
                names[index] = name;
                numbers[index] = number;
                return true;
            }
            return false;
        }
        public long GetNumber(string name)
        {
            for (int i = 0; i < size; i++)
            {
                if (names[i] == name)
                    return numbers[i];

            }
            return -1;

        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < size)
                    return $"Name :{names[index]} ,Number : {numbers[index]} ";
                return "Out Of Range";
            }
        }
        //update number just when name found
        public long this[string name]
        {
            get
            {
                for (int i = 0; i < size; i++)
                {
                    if (names[i] == name)
                        return numbers[i];

                }
                return -1;
            }
            set
            {
                for (int i = 0; i < size; i++)
                {
                    if (names[i] == name)
                        numbers[i] = value;
                }
            }
        }
    }
}