//// exec 1
//{
//    try
//    {
//        int qualquer = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Numero inserido corretamente");
//    }
//    catch (Exception ex)
//    {
//        if (ex.GetType().Name.ToLower() == "overflowexception")
//        {
//            Console.WriteLine("Numero grande demais");
//        }
//        else if (ex.GetType().Name.ToLower() == "formatexception")
//        {
//            Console.WriteLine("Sra. Margot, não insira letras");
//        }
//        else
//        {
//            for (int i = 0; i < 10000; i++)
//            {
//                Console.WriteLine("ERRO");
//                Console.Clear();
//            }
//        }
//    }
//}


// exec 2
{
    //List<double> numeros = new List<double>();

    //while (numeros.Count > 3)
    //{
    //    try
    //    {
    //        Console.WriteLine($"Insira o {numeros.Count + 1}º");
    //        double entrada = Convert.ToDouble(Console.ReadLine());
    //        if(!(entrada >= 0 && entrada <= 10))
    //        {
    //            throw new OverflowException();
    //        }
    //    }
    //    catch (Exception)
    //    {

    //    }
    //}
}

// desafio escada
{
    double altura, comprimento, degraus, concreto;
    Console.WriteLine("Insira a altura da escada.");
    altura = Convert.ToDouble(Console.ReadLine());
    degraus = altura / 18;
    degraus = Math.Ceiling(degraus);
    Console.WriteLine($"A escada deverá ter {degraus} degraus");
    comprimento = degraus * 30;
    Console.WriteLine($"A escada deverá ter {comprimento}m de comprimento");
    concreto = 0;
    for (int i = 0; i <= degraus; i++)
    {
        concreto += (degraus * 1.3246) * (i + 1);
    }
    concreto = Math.Ceiling(concreto);
    Console.WriteLine($"Serão necessários {concreto}L de cimento");

}