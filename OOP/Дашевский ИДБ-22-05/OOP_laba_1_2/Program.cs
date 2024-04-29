using OOP_laba_1_2;

Console.WriteLine("Hello, World!");

IDateTimeFormatter date = new EuropeanDateTimeFormatter();
DecorPost post = new DecorPost(date);
DecorPre pre = new DecorPre(post);
DecorPost decorPost = new DecorPost(pre);

Console.WriteLine(decorPost.FormatDateTime());
Console.ReadLine();
