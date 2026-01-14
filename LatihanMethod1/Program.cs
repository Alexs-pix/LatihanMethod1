int c = 0;

void tambah (int a, int b)
{
    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}

void kurang (int a, int b)
{
    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}

void kali (int a, int b)
{
    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}

void bagi (int a, int b)
{
    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

tambah(7, 4);
kurang(9, 2);
tambah(4, 3);
kali(9, 7);
bagi(6, 4);