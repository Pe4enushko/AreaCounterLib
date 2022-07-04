using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class CheckerTests
    {
        [Test]
        public void IsTriangleRightTest()
        {
            double a;
            int b, c;
            b = 19;
            c = 15;
            a = 24.20743687382;
            Assert.IsTrue(Checker.CheckTriangleIsRight(a,b,c));
            a = b = c = 2;
            Assert.IsTrue(!Checker.CheckTriangleIsRight(a, b, c));
        }
    }
}
