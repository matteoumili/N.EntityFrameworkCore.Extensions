﻿using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using X.EntityFrameworkCore.Extensions.Test.DbContextExtensions;

namespace X.EntityFrameworkCore.Extensions.Test.DbSetExtensions;

[TestClass]
public class Truncate : DbContextExtensionsBase
{
    [TestMethod]
    public void Using_Dbset()
    {
        var dbContext = SetupDbContext(true);
        int oldOrdersCount = dbContext.Orders.Count();
        dbContext.Orders.Truncate();
        int newOrdersCount = dbContext.Orders.Count();

        Assert.IsTrue(oldOrdersCount > 0, "Orders table should have data");
        Assert.IsTrue(newOrdersCount == 0, "Order table should be empty after truncating");
    }
}