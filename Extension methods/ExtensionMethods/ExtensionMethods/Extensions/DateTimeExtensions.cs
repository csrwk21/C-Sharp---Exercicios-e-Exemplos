using System.Globalization;

 // ao criar um Extension Method para uma Classe ou Struct colocando a classe no mesmo namespace no tipo que esta extendo
namespace System //ExtensionMethods.Extensions    

{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duaration = DateTime.Now.Subtract(thisObj);

            if (duaration.TotalHours < 24.0)
            {
                return duaration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duaration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
