using Business.Concretes;
using CrudMethods.Concretes;
using Entities.Concretes;




CourseManager courseManager = new CourseManager(new CourseCrudMethods());

List<Course> courses = courseManager.GetCourses();

CategoryManager categoryManager = new CategoryManager( new Category_Crud_Methods());

List<Category> categories = categoryManager.GetCategories();


for (int i = 0; i < categories.Count; i++)
{
    Console.WriteLine("Kurs Kategori adı = " + categories[i].CategoryName);
}

categoryManager.Add(new Category() {Id=4, CategoryName="Yeni"});
CategoryManager categoryManager2 = new CategoryManager(new Category_Crud_Methods());
List<Category> categories2 = categoryManager.GetCategories();

for (int i = 0; i < categories2.Count; i++)
{
    Console.WriteLine("Kurs Kategori adı = " + categories2[i].CategoryName);
}