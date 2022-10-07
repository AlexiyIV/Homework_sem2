Console.Write("введите трёхзначное число ");
int N = Math.Abs(int.Parse(Console.ReadLine()));
int n2 = 0;
if ( N >= 100 && N < 1000 ){
    n2 = ( N - N / 100 * 100 ) / 10;
    Console.WriteLine(n2);
}
else {
    Console.WriteLine("число не трёхзначное");
}

