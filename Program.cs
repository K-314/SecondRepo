// zad1


// Console.Write("Length: ");
// int n = int.Parse(Console.ReadLine());

// double[] array = new double[n];

// for(int i = 0; i < n; i++)
// {
//   Console.Write("Element[" + i + "]: ");
//   array[i] = double.Parse(Console.ReadLine());
// }

// // TODO zrobic:

// Console.Write("Podaj liczbę na której chcesz działać: ");
// int y = int.Parse(Console.ReadLine());


// Console.Write("Podaj działanie arytmetyczne na którym chcesz działać: +, -, *, / ");
// string działanie = Console.ReadLine();


// for(int i = 0; i < n; i++) {

//     switch(działanie) {
//         case "+": array[i] += y; break;
//         case "-": array[i] -= y; break;
//         case "*": array[i] *= y; break;
//         case "/": array[i] /= y; break;
//         default:
//             Console.WriteLine("Nieobsługiwana operacja!");
//             return;
//     } 
//     Console.WriteLine("Element[" + i + "]: " + array[i]);
// }











//kotynuacja, zmiana sposobu wprowadzania liczb przez użytkownika. Użytkownik poda łańcuch liczb oddzielonych spacjami.







// Console.Write("Length: ");
// int n = int.Parse(Console.ReadLine());

// double[] array = new double[n];

// for(int i = 0; i < n; i++)
// {
//   Console.Write("Element[" + i + "]: ");
//   array[i] = double.Parse(Console.ReadLine());
// }

// // TODO zrobic:

// Console.Write("Podaj liczbę na której chcesz działać: ");
// int y = int.Parse(Console.ReadLine());


// Console.Write("Podaj działanie arytmetyczne na którym chcesz działać: +, -, *, / ");
// string działanie = Console.ReadLine();


// for(int i = 0; i < n; i++) {

//     switch(działanie) {
//         case "+": array[i] += y; break;
//         case "-": array[i] -= y; break;
//         case "*": array[i] *= y; break;
//         case "/": array[i] /= y; break;
//         default:
//             Console.WriteLine("Nieobsługiwana operacja!");
//             return;
//     } 
//     // Console.WriteLine(array[i]);
// }

// string str = 

// string[] result = str.Split(" ");
// Console.WriteLine(result[]);


// //nie wiem










// zadanie 4 do domu i dokonczyc 3
//sortowanie bombelkowe - poczytac mozna zastosowac









//zad 4


Console.Write("Length: ");
int n = int.Parse(Console.ReadLine());  //podajemy n 

double[] array = new double[n]; //tworzenie tablicy
Random rng = new Random(); //tworzenie random, poza pętlą

for(int i = 0; i < n; i++) 
{
  int nbr = rng.Next(0, 100); //losowa liczba 0-99

  Console.Write(nbr + ", ");
  array[i] = nbr; //dodanie losowej l. do tablicy i wyswietlenie
}



for(int k = 0; k < n-1; k++) {  //sortowanie bombelkowe


  for(int j = 0; j < n-1-k; j++) {

    if (array[j] > array[j + 1]) {
      double x = array[j]; 
      array[j] = array[j+1];
      array[j+1] = x;
    }
  }
}

Console.WriteLine("Posortowane liczby: ");
for (int i = 0; i < n; i++) {
  Console.Write(array[i] + ", ");
}









///wypisac 
///


lol

