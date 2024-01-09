int x = -5;
int y = -8;
if (x > 0 && y > 0){
    Console.Write("Координаты на 1 четверти плоскости");
}
else if (x < 0 && y > 0){
    Console.Write("Координаты на 2 четверти плоскости");
}
else if (x < 0 && y < 0){
    Console.Write("Координаты на 3 четверти плоскости");
}
else if (x > 0 && y < 0){
    Console.Write("Координаты на 4 четверти плоскости");
}
