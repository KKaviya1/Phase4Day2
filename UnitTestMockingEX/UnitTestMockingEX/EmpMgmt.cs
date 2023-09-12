using System;


namespace EmpMgmt
{
    public class CheckEmp
    {
        public virtual bool checkEmp()
        {
            throw new NotImplementedException();
        }

    }
    public class ProcessEmployee
    {
        public bool InsertEmp(CheckEmp objCheck)
        {
            objCheck.checkEmp();
            return true;
        }
    }
}
