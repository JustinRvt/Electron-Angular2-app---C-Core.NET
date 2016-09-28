using System.Data.SqlClient;

namespace Demo.Framework.AccesDonnees
{
   public static class ReaderExtension
    {
       public static T SafeGeValue<T>(this SqlDataReader pReader, string pName)
       {
           int lIndex = pReader.GetOrdinal(pName);
           if (!pReader.IsDBNull(lIndex))
           {
               return (T)pReader.GetValue(lIndex);
           }

           return default(T);
       }
    }
}