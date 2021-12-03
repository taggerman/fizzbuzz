

//man laver en int der hedder i, så er i = med 1,
//hvis i er inden for 0-100 så må loopet køre in gang 
//og for hver gang loopet køre bliver i værdi + med en
//og så når den rammer 100 så er i = med 100 og så stopper loopet.
for (int i = 1; i <= 100; i++)
{
    //så hvis i går op i 3 og 5 så køre console wirteline med fizzbuzz
    if (i%3==0&&i%5==0)
    {
        Console.WriteLine("fizzbuzz");
    }
    //og hvis i kun går op i 3 så bliver der skrevet fizz
    else if (i%3==0)
    {
        Console.WriteLine("fizz");
    }
    //hvis i går op i 5 bliver der skrevet buzz
    else if (i%5==0)
    {
        Console.WriteLine("buzz");
    }
    //og hvis i ikke går op i noget bliver tallet bare skrevet ud.
    else
    {
        Console.WriteLine(i);
    }
}