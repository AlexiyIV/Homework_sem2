Console.Write("введите число ");
int lm = 0;
double N = Math.Abs(double.Parse(Console.ReadLine()));
double n = N;
// определяем есть-ли третья цифра?
if ( n < 100 ){
    Console.WriteLine("нет третьей цифры");
}
//
// определяем длинну массива
else {
    while (n / 10 > 0 ){
        n = (n - n % 10) / 10;
        lm++;
    }
    Console.WriteLine( lm );
//
// заполняем массив
    int[] a = new int[lm];
    for (int i = 0; i < a.Length; i++){
        a[i] = (int) N %10;
        N = (N - N % 10)/10;
    }
    Console.WriteLine( a[lm-3] ); // печатаем третью цифру введёного числа
    for (int i = 0; i < a.Length; i++){
    Console.Write(a[i] + " ");   // печатаем весь массив
    }
}