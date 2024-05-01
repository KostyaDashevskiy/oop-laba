using OOP_laba_1_2;

IDateTimeFormatter date = new EuropeanDateTimeFormatter();
DecorPost post = new DecorPost(date);   //dateKon
DecorPre pre = new DecorPre(post);   //DasdateKon
DecorPost decorPost = new DecorPost(pre);   //DasdateKonKon

Console.WriteLine(decorPost.FormatDateTime());
//Console.ReadLine();
