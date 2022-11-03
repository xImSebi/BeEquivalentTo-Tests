using BeEquivalentTo_Tests.Models;

namespace BeEquivalentTo_Tests
{
    public class SimpleTests
    {
        /// <summary>
        /// Gleiche Parameter, gleiche Werte
        /// Gleiche Klasse 2 mal verwendet
        /// Erwartet: Erfolg
        /// Ergebnis: Erfolg
        /// </summary>
        [Fact]
        public void Test1()
        {
            var value1 = new TestClass1()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 3,
                    Value2 = "fünf"
                },
                Value2 = "text",
                Value3 = 50
            };
            var value2 = new TestClass1()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 3,
                    Value2 = "fünf"
                },
                Value2 = "text",
                Value3 = 50
            };

            value1.Should().BeEquivalentTo(value2);
        }
        [Fact]
        public void Test12()
        {
            var value1 = new TestClass1()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 3,
                    Value2 = "fünf"
                },
                Value2 = "text",
                Value3 = 50
            };
            var value2 = new TestClass1()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 3,
                    Value2 = "fünf"
                },
                Value2 = "text",
                Value3 = 50
            };

            value2.Should().BeEquivalentTo(value1);
        }

        /// <summary>
        /// Gleiche Parameter, verschiedene Werte
        /// Gleiche Klasse 2 mal verwendet, bei 2. Instanz andere Werte verwendet als bei der ersten
        /// Erwartet: Fehlschlag
        /// Ergebnis: Fehlschlag
        /// </summary>
        [Fact]
        public void Test2()
        {
            var value1 = new TestClass1()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 3,
                    Value2 = "fünf"
                },
                Value2 = "text",
                Value3 = 50
            };
            var value2 = new TestClass1()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 6,
                    Value2 = "sieben"
                },
                Value2 = "huhu",
                Value3 = 40
            };

            value1.Should().BeEquivalentTo(value2);
        }
        [Fact]
        public void Test22()
        {
            var value1 = new TestClass1()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 3,
                    Value2 = "fünf"
                },
                Value2 = "text",
                Value3 = 50
            };
            var value2 = new TestClass1()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 6,
                    Value2 = "sieben"
                },
                Value2 = "huhu",
                Value3 = 40
            };

            value2.Should().BeEquivalentTo(value1);
        }

        /// <summary>
        /// Verschiedene Parameter, verschiedene Werte
        /// Unterschiedliche Klassen verwendet, bei den übereinstimmenden Parametern verschiedene Werte verwendet
        /// Erwartet: Fehlschlag
        /// Ergebnis: Fehlschlag
        /// </summary>
        [Fact]
        public void Test3()
        {
            var value1 = new TestClass1()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 3,
                    Value2 = "fünf"
                },
                Value2 = "text",
                Value3 = 50
            };
            var value2 = new TestClass2()
            {
                Value1 = new ExampleClass2
                {
                    Value1 = 6,
                    Value2 = 50.6
                },
                Value2 = 86.543,
                Value3 = 40
            };

            value1.Should().BeEquivalentTo(value2);
        }
        [Fact]
        public void Test32()
        {
            var value1 = new TestClass1()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 3,
                    Value2 = "fünf"
                },
                Value2 = "text",
                Value3 = 50
            };
            var value2 = new TestClass2()
            {
                Value1 = new ExampleClass2
                {
                    Value1 = 6,
                    Value2 = 50.6
                },
                Value2 = 86.543,
                Value3 = 40
            };

            value2.Should().BeEquivalentTo(value1);
        }

        /// <summary>
        /// Verschiedene Parameter, gleiche Werte
        /// Unterschiedliche Klassen verwendet, bei den übereinstimmenden Parametern aber gleiche Werte verwendet
        /// Erwartet: Fehlschlag
        /// Ergebnis: Fehlschlag
        /// </summary>
        [Fact]
        public void Test4()
        {
            var value1 = new TestClass1()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 3,
                    Value2 = "fünf"
                },
                Value2 = "text",
                Value3 = 50
            };
            var value2 = new TestClass2()
            {
                Value1 = new ExampleClass2
                {
                    Value1 = 3,
                    Value2 = 50.6
                },
                Value2 = 86.543,
                Value3 = 50
            };

            value1.Should().BeEquivalentTo(value2);
        }
        [Fact]
        public void Test42()
        {
            var value1 = new TestClass1()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 3,
                    Value2 = "fünf"
                },
                Value2 = "text",
                Value3 = 50
            };
            var value2 = new TestClass2()
            {
                Value1 = new ExampleClass2
                {
                    Value1 = 3,
                    Value2 = 50.6
                },
                Value2 = 86.543,
                Value3 = 50
            };

            value2.Should().BeEquivalentTo(value1);
        }

        /// <summary>
        /// Klassen grundsätzlich mit gleichen Parametern, 2. Klasse fehlt allerdings ein Parameter
        /// Vorhandene Parameter haben gleiche Werte
        /// Erwartet: Fehlschlag
        /// Ergebnis: Erfolg und Fehlschlag (Hängt davon ab ob A mit B oder B mit A verglichen wird)
        /// </summary>
        [Fact]
        public void Test5()
        {
            var value1 = new TestClass1()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 3,
                    Value2 = "fünf"
                },
                Value2 = "text",
                Value3 = 50
            };
            var value2 = new TestClass3()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 3,
                    Value2 = "fünf"
                },
                Value2 = "text"
            };

            value1.Should().BeEquivalentTo(value2);
        }
        [Fact]
        public void Test52()
        {
            var value1 = new TestClass1()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 3,
                    Value2 = "fünf"
                },
                Value2 = "text",
                Value3 = 50
            };
            var value2 = new TestClass3()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 3,
                    Value2 = "fünf"
                },
                Value2 = "text"
            };

            value2.Should().BeEquivalentTo(value1);
        }

        /// <summary>
        /// Klassen grundsätzlich mit gleichen Parametern, 2. Klasse fehlt allerdings ein Parameter
        /// Vorhandene Parameter haben verschiedene Werte
        /// Erwartet: Fehlschlag
        /// Ergebnis: Fehlschlag
        /// </summary>
        [Fact]
        public void Test6()
        {
            var value1 = new TestClass1()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 3,
                    Value2 = "fünf"
                },
                Value2 = "text",
                Value3 = 50
            };
            var value2 = new TestClass3()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 2,
                    Value2 = "f662nf"
                },
                Value2 = "blub"
            };

            value1.Should().BeEquivalentTo(value2);
        }
        [Fact]
        public void Test62()
        {
            var value1 = new TestClass1()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 3,
                    Value2 = "fünf"
                },
                Value2 = "text",
                Value3 = 50
            };
            var value2 = new TestClass3()
            {
                Value1 = new ExampleClass1
                {
                    Value1 = 2,
                    Value2 = "f662nf"
                },
                Value2 = "blub"
            };

            value2.Should().BeEquivalentTo(value1);
        }
    }
}