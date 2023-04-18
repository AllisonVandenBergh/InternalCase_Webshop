using System;
namespace Webshop.Web.Endpoints
{
	public static class ApiEndpoints
	{
        private const string ApiBase = "/api";

        public static class Admin
        {
            private const string Base = $"{ApiBase}/admin/products";

            public const string Create = Base;
            public const string Get = $"{Base}/{{id:guid}}";
            public const string GetAll = Base;
            public const string Update = $"{Base}/{{id:guid}}";
            public const string Delete = $"{Base}/{{id:guid}}";
            public const string RandomMulti = $"{Base}/random-multiple";
            public const string RandomSingle = $"{Base}/random-single";
        }
    }
}

