using DataGridView1.Property;


namespace CLL1
{
    public class Class1
    {
        private List<Abiturient> abiturients = new List<Abiturient>();

        public Class1() { }
        public List<Abiturient> GetList()
        {
            return  abiturients;
        }
        public void Add(Abiturient data)
        {
            abiturients.Add(data);
        }
        public void Edit(Abiturient id, Abiturient data)
        {
            var index = abiturients.IndexOf(id);
            abiturients[index] = data;
        }
        public void Delete(Abiturient data)
        {
            abiturients.Remove(data);
        }
    }
}