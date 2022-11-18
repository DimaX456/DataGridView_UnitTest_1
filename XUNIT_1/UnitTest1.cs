using CLL1;
using DataGridView1;
using DataGridView1.Gender1;
using DataGridView1.Property;
using Xunit.Abstractions;

namespace XUNIT_1
{
    public class UnitTest1
    {
        [Fact]
        public void AddButton()
        {
            Class1 CL1 = new();
            Abiturient abiturient = new()
            {
                Id = Guid.NewGuid(),
                FullName = "AEE",
                Gender = Gender.Female,
                Birthday = DateTime.Now.AddYears(-16),
                FormaObychenia = FormaObychenia.Ochnoe,
                Matem = 80,
                Rus = 78,
                Inf = 91,
                Sum =249,
        };
            CL1.Add(abiturient);
            var result = CL1.GetList();
            Assert.Equal(abiturient, result[0]);
        }
        [Fact]
        public void EditButton()
        {
            Class1 CL1 = new();
            Abiturient abiturient = new()
            {
                Id = Guid.NewGuid(),
                FullName = "AEE",
                Gender = Gender.Female,
                Birthday = DateTime.Now.AddYears(-16),
                FormaObychenia = FormaObychenia.Ochnoe,
                Matem = 80,
                Rus = 78,
                Inf = 91,
                Sum = 249,
            };
            CL1.Add(abiturient);
            Abiturient abiturient1 = new()
            {
                Id = Guid.NewGuid(),
                FullName = "EEA",
                Gender = Gender.Female,
                Birthday = DateTime.Now.AddYears(-16),
                FormaObychenia = FormaObychenia.Ochnoe,
                Matem = 60,
                Rus = 87,
                Inf = 19,
                Sum = 294,
            };
            CL1.Edit(abiturient, abiturient1);
            var result = CL1.GetList();
            Assert.Equal(abiturient1, result[0]);
        }
        [Fact]
        public void DeleteButton()
        {
            Class1 CL1 = new();
            Abiturient abiturient = new()
            {
                Id = Guid.NewGuid(),
                FullName = "OEA",
                Gender = Gender.Female,
                Birthday = DateTime.Now.AddYears(-16),
                FormaObychenia = FormaObychenia.Ochnoe,
                Matem = 80,
                Rus = 78,
                Inf = 91,
                Sum = 249,
            };
            CL1.Add(abiturient);
            CL1.Delete(abiturient);
            var result = CL1.GetList();
            Assert.Empty(result);
        }
    }
}