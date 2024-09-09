using Newtonsoft.Json;

namespace CoreSession_0.ExtensionMethods
{
    public static class SessionExtension
    {
        #region JsonOrnek
        /*

        Egitmen egt = new Egitmen();

       egt.Name = "Cagri";
       egt.LastName = "Yolyapar";


        Json.Serialize(egt);




       {
       "Name":"Cagri",
       "LastName":"Yolyapar"
       }

         //public SessionExtension()
        //{
        //    object a = new { Name = "Cagri", LastName = "Yolyapar" };

            
        //}


        //public SessionExtension(string a)
        //{
        object a = GetSession("Egitmen");
          Egitmen egt =  Json.Deserialize<Egitmen>(a);
        //}











        */
        #endregion


        public static void SetObject(this ISession session,string key,object value)
        {
            string objectString = JsonConvert.SerializeObject(value);
            session.SetString(key, objectString);
        }

        public static T GetObject<T>(this ISession session,string key) where T: class
        {
            string objectString = session.GetString(key);
            if (string.IsNullOrEmpty(objectString))
            {
                return null;
            }
            T deserializedObject = JsonConvert.DeserializeObject<T>(objectString);
            return deserializedObject;
        }
    




    }
}
