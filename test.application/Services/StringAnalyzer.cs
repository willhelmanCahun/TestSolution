using System;
using test.application.Services.Interfaces;

namespace test.application.Services
{
    public class StringAnalyzer : IStringAnalyzer
    {
        /// <summary>
        /// Method to ReArrange input array base on a second array that contains the desire order of the elements
        /// <para>Sample</para>
        /// <para>arrayToRearragnge={ "Sonia", "Maria", "Wood", "Dempster" }</para>
        /// <para>desireOrder=={ "4", "1", "2", "3" };</para>
        /// <para>output={ "Dempster", "Sonia", "Maria", "Wood" };</para>
        /// </summary>
        /// <param name="arrayToRearrange">Array of strings to be rearrange sample individuals={ "Sonia", "Maria", "Wood", "Dempster" }</param>
        /// <param name="desireOrder">Array of strings that contains the indexes of the desire element in the position,sample desireOrder={ "4", "1", "2", "3" };</param>
        /// <returns>array of string that contains the elements of the Input array in the order specified by the desireOrder array, in case of any error this method throwns an Exception</returns>
        public string[] ReArrangeString(string[] arrayToRearrange, string[] desireOrder)
        {
            string[] reOrderedNames= new string[desireOrder.Length];
            if (checkDataIntegrity(arrayToRearrange, desireOrder)) {
                int index = 0;
                foreach (string element in desireOrder) {
                    reOrderedNames[index] = arrayToRearrange[int.Parse(element)-1];
                    index++;
                }
            }
            return reOrderedNames;
        }
        /// <summary>
        /// Private method to check data integrity before trying to perform any operation
        /// <para>Checked exceptions</para>
        /// <para>1.Empty arrayToRearrange array </para>
        /// <para>2.Empty desireOrder array</para>
        /// <para>3.Number of elements of both parameters must be equal</para>
        /// <para>4.DesireOrder array elements must be integer</para>
        /// <para>5.desireOrder array elements must be an index of an element in arrayToRearrange array</para>
        /// </summary>
        /// <param name="arrayToRearrange">Array of strings to be rearrange sample individuals={ "Sonia", "Maria", "Wood", "Dempster" }</param>
        /// <param name="desireOrder">Array of strings that contains the indexes of the desire element in the position,sample desireOrder={ "4", "1", "2", "3" };</param>
        /// <returns>true if all checks are valid. Exception if any is false</returns>
        private bool checkDataIntegrity(string[] arrayToRearrange, string[] desireOrder)
        {
            bool existsIntegrity = true;
            if (arrayToRearrange.Length == 0) {
                throw new Exception("Individuals names array is empty, please verify");
            }
            if (desireOrder.Length == 0)
            {
                throw new Exception("Desire order array is empty, please verify");
            }

            if (arrayToRearrange.Length != desireOrder.Length)
            {
                throw new Exception("Individual  Names Array and Desire order array number of elements does not match, please verify!");
            }

            int maxIndexNumber = arrayToRearrange.Length;
            foreach (string element in desireOrder)
            {
                int number;
                if (!int.TryParse(element, out number))
                {
                    throw new Exception("Desire order array only allows elements of type Integer");
                    
                }
                else {
                    if (number > maxIndexNumber || number<=0) {
                        throw new Exception("Desire order array element is out of bounds");
                    }
                }
                
            }
            return existsIntegrity;
        }
    }
}
