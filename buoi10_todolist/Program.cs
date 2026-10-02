using System.Text;
using Models; // Using là cú pháp import namespace

Console.OutputEncoding = Encoding.UTF8;
Menu menu = new Menu();
FoodMenu foodMenu = new FoodMenu();

// Chức năng 1: Hiển thị menu
// menu.Title = "Chương trình TodoApp";
// menu.DisplayMenu();

// Quản lý món ăn
foodMenu.DisplayMenu();