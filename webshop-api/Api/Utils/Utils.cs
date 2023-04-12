namespace Api.Validators
{
    public static class Utils
    {
        public static Guid? StringToGuid(string stringGuid)
        {
            if (Guid.TryParse(stringGuid, out Guid guid))
                return guid;
            else
                return null;
        }
    }
}

