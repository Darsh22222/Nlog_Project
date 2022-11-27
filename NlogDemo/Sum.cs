using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogDemo
{
    internal class Sum
    {
        private readonly Nlog nLog = new Nlog();
        public int add(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                nLog.LogDebug("Debug Successfull : Sum()");
                nLog.LogError("Expecting null values");
                nLog.LogWarn("secondNumber or secondNumber should not be 0 ");
            }
            int result = firstNumber + secondNumber;
            nLog.LogDebug("Debug Successfull : Sum()");
            nLog.LogInfo("Sum Method passed, Result" + result);
            return result;
        }
    }
}
