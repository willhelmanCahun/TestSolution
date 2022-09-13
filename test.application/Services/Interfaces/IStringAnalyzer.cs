
namespace test.application.Services.Interfaces
{
    public interface IStringAnalyzer
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
        string[] ReArrangeString(string[] individualsNames, string[] desireOrder);

    }
}
