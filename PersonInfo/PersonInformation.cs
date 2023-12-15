using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    public class PersonInformation
    {

        public string[] GetInfo(string information)
        {
            string[] newInfo = information.Split(";");

            return newInfo;
        }


        public List<string> GetEachPersonInfo(string[] eachPersonInfo)
        {

            string[] splitedInfo = new string[3];
            List<string> newInfo = new List<string>();

            foreach (string eachPerson in eachPersonInfo)
            {
                splitedInfo = eachPerson.Split(",");
                newInfo.AddRange(splitedInfo);
            }

            return newInfo;
        }

        public int CalculateSumAge(List<string> info)
        {
            int age = 0;
            string[] infoArray = info.ToArray();

            for (int i = -1; i < infoArray.Length; i += 3)
            {
                while (i >= 2)
                {
                    string convertedAge = infoArray[i].ToString();
                    age += Convert.ToInt32(convertedAge);
                    break;
                }

            }
            return age;

        }

        public int CalculateAvgAge(int sumAge, int personCount)
        {
            int avgAge = sumAge / personCount;
            return avgAge;
        }

    }
}
