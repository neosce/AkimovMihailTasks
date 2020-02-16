using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPAM.ListUserAward.WebPages.Models
{
    public static class Counter
    {

        public static int Value { get; private set; }

        public static void Increase() => Value++;

    }
}