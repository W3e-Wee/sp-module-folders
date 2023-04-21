using System;
using System.Collections.Generic;
using System.Text;

namespace DSAL_CA2.Classes
{
    [Serializable]
    internal static class General
    {
        public static string GenerateUUID()
        {
            Guid uuid = Guid.NewGuid();
            string uuidString = uuid.ToString();

            return uuidString;
        } // end of GenerateUUID method
    }//end of General class
}
