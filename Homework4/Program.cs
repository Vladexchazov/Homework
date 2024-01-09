int N = 1234;
if (N < 10){
   Console.WriteLine(N);
}
else{
 while (N > 0){
 int num = N % 10;
  N /= 10;
 if (N > 0){

   Console.Write(num + ",");
 }

else{
Console.WriteLine(num);
}
 }
}

