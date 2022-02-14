// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool x = true;
bool y = true;
if (!(x || y) == (!x) && (!y))
    Console.WriteLine(true);
else
    Console.WriteLine(false);

bool x2 = false;
bool y2 = false;
if (!(x2 || y2) == (!x2) && (!y2))
    Console.WriteLine(true);
else
    Console.WriteLine(false);

bool x3 = true;
bool y3 = false;
if (!(x3 || y3) == (!x3) && (!y3))
    Console.WriteLine(true);
else
    Console.WriteLine(false);

bool x4 = false;
bool y4 = true;
if (!(x4 || y4) == (!x4) && (!y4))
    Console.WriteLine(true);
else
    Console.WriteLine(false);