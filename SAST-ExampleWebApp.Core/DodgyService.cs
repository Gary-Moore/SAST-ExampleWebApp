using SAST.WebApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAST_ExampleWebApp.Core
{
    public class DodgyService
    {
        public void PerformDodgyDatabaseAction()
        {
            var repository = new Repository();

            repository.UnsafeQuery("connectionstring", "' OR 1=1 --", "[PLACEHOLDER]");
        }
    }
}
