using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwiftInsightsV2.Entities;

namespace SwiftInsightsV2
{
    internal static class Modele
    {
        private static BddSwiftinsightContext monModel;
        public static void init()
        {
            monModel = new BddSwiftinsightContext();
        }

        #region Récupère administateur

        public static List<User> getAdmin()
        {
            List<User> liste = new List<User>();
            liste = monModel.Users
                .Where(x => x.IsAdmin == 1)
                .ToList();
            return liste;
        }

        #endregion
    }
}
