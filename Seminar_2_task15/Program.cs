// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введи цифру дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

void Day (int num) {
  if(num==6||num==7){
     Console.WriteLine("Это выходной день ");
  }
else if(num<1 || num>7){
  Console.WriteLine("Это не день недели ");
}
else Console.WriteLine("Это не выходной день ");
}
Day(num);
