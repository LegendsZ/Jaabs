using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAABS.ATMMachine
{
    internal class ATMMachine
    {
        public int m_MachineNumber;
        public int m_TotalCash;

        public ATMMachine(int machineNumber, int totalCash)
        {
            m_MachineNumber= machineNumber;
            m_TotalCash = totalCash;
        }

        public bool DepositCash(int toDeposit)
        {

            return false;
        }

        //make a cheque class?
        public bool DepositCheques(int toDeposit)
        {

            return false;
        }

        public bool WithdrawCash(int toWithdraw)
        {

            return false;
        }

        //make transfer struct plz
        public bool Transfer()
        {

            return false;
        }

        public bool payPayees()
        {
            return false;
        }

        public int checkBalance()
        {
            return 0;
        }

        //make transaction class plz, change ret type of the func to Transaction list
        public int checkTransactions()
        {
            return -1;
        }

        public bool addCash()
        {
            return false;
        }

        //add check functions for atm related methods.
    }
}
