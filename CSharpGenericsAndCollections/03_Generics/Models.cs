using System;
namespace CSharpGenericsAndCollections._Generics
{
    public class BaseModel
    {
        public int Id { get; set; }
    }

    public class Person : BaseModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Item : BaseModel
    {
        public string Description { get; set; }
    }
}
