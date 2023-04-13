namespace Api.Validators
{
    public static class Utils
    {
        public static Guid? StringToGuid(string stringGuid)
        {
            if (Guid.TryParse(stringGuid, out Guid guid))
                return guid;

            return null;
        }

        public static Guid? ValidateGuid(Guid guid)
        {
            if(Guid.TryParse(guid.ToString(), out _))
                return guid;

            return null;
        }
    }
}

