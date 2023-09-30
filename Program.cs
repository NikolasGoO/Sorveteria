using Sorveteria.Entities;
using System.Collections.Generic;

List<Sorvete> sorvetes = new List<Sorvete>();
string continuar = "SIM";
while (continuar == "SIM")
{
    Console.WriteLine("\nBem vindos a Sorveteria do Tio Anastácio\n\nQuais sabores você deseja:\n\n1.MORANGO,\n2.BAUNILHA,\n3.CHOCOLATE,\n4.CARAMELO,\n5.AMÊNDOA,\n6.COCO,\n7.MENTA,\n8.LIMÃO,\n9.FRAMBOESA,\n10.ABACAXI,\n11.PISTACHE,\n12.AMORA,\n13.FLOCOS,\n14.PÊSSEGO,\n15.Amendoim,\n16.MANGA,\n17.MARACUJÁ");
    Console.WriteLine("\nDigie o Numero do Sabor que deseja");
    int saborSorvete = Convert.ToInt32(Console.ReadLine());
    switch (saborSorvete)
    {
        case 1:
            Console.WriteLine("Você selecionou o sabor Morango");
            Sorvete sorveteMorango = new Sorvete();
            sorveteMorango.SaborSorvete = Sorveteria.Enums.SaborSorvete.MORANGO;
            sorvetes.Add(sorveteMorango);
                break;
        case 2:
            Console.WriteLine("Você selecionou o sabor Baunilha");
            Sorvete sorveteBaunilha = new Sorvete();
            sorveteBaunilha.SaborSorvete = Sorveteria.Enums.SaborSorvete.BAUNILHA;
            sorvetes.Add(sorveteBaunilha);
                break;
        case 3:
            Console.WriteLine("Você selecionou o sabor Chocolate");
            Sorvete sorveteChocolate = new Sorvete();
            sorveteChocolate.SaborSorvete = Sorveteria.Enums.SaborSorvete.CHOCOLATE;
            sorvetes.Add(sorveteChocolate);
                break;
        case 4:
            Console.WriteLine("Você selecionou o sabor Caramelo");
            Sorvete sorveteCaramelo = new Sorvete();
            sorveteCaramelo.SaborSorvete = Sorveteria.Enums.SaborSorvete.CARAMELO;
            sorvetes.Add(sorveteCaramelo);
            break;
        case 5:
            Console.WriteLine("Você selecionou o sabor Amêndoa");
            Sorvete sorveteAmendoa = new Sorvete();
            sorveteAmendoa.SaborSorvete = Sorveteria.Enums.SaborSorvete.AMÊNDOA;
            sorvetes.Add(sorveteAmendoa);
            break;
        case 6:
            Console.WriteLine("Você selecionou o sabor Coco");
            Sorvete sorveteCoco = new Sorvete();
            sorveteCoco.SaborSorvete = Sorveteria.Enums.SaborSorvete.COCO;
            sorvetes.Add(sorveteCoco);
            break;
        case 7:
            Console.WriteLine("Você selecionou o sabor Menta");
            Sorvete sorveteMenta = new Sorvete();
            sorveteMenta.SaborSorvete = Sorveteria.Enums.SaborSorvete.MENTA;
            sorvetes.Add(sorveteMenta);
            break;
        case 8:
            Console.WriteLine("Você selecionou o sabor Limão");
            Sorvete sorveteLimao = new Sorvete();
            sorveteLimao.SaborSorvete = Sorveteria.Enums.SaborSorvete.LIMÃO;
            sorvetes.Add(sorveteLimao);
            break;
        case 9:
            Console.WriteLine("Você selecionou o sabor Framboesa");
            Sorvete sorveteFramboesa = new Sorvete();
            sorveteFramboesa.SaborSorvete = Sorveteria.Enums.SaborSorvete.FRAMBOESA;
            sorvetes.Add(sorveteFramboesa);
            break;
        case 10:
            Console.WriteLine("Você selecionou o sabor Abacaxi");
            Sorvete sorveteAbacaxi = new Sorvete();
            sorveteAbacaxi.SaborSorvete = Sorveteria.Enums.SaborSorvete.ABACAXI;
            sorvetes.Add(sorveteAbacaxi);
            break;
        case 11:
            Console.WriteLine("Você selecionou o sabor Pistache");
            Sorvete sorvetePistache = new Sorvete();
            sorvetePistache.SaborSorvete = Sorveteria.Enums.SaborSorvete.PISTACHE;
            sorvetes.Add(sorvetePistache);
            break;
        case 12:
            Console.WriteLine("Você selecionou o sabor Amora");
            Sorvete sorveteAmora = new Sorvete();
            sorveteAmora.SaborSorvete = Sorveteria.Enums.SaborSorvete.AMORA;
            sorvetes.Add(sorveteAmora);
            break;
        case 13:
            Console.WriteLine("Você selecionou o sabor Flocos");
            Sorvete sorveteFlocos = new Sorvete();
            sorveteFlocos.SaborSorvete = Sorveteria.Enums.SaborSorvete.FLOCOS;
            sorvetes.Add(sorveteFlocos);
            break;
        case 14:
            Console.WriteLine("Você selecionou o sabor Pêssego");
            Sorvete sorvetePessego = new Sorvete();
            sorvetePessego.SaborSorvete = Sorveteria.Enums.SaborSorvete.PÊSSEGO;
            sorvetes.Add(sorvetePessego);
            break;
        case 15:
            Console.WriteLine("Você selecionou o sabor Amendoim");
            Sorvete sorveteAmendoim = new Sorvete();
            sorveteAmendoim.SaborSorvete = Sorveteria.Enums.SaborSorvete.AMENDOIM;
            sorvetes.Add(sorveteAmendoim);
            break;
        case 16:
            Console.WriteLine("Você selecionou o sabor Manga");
            Sorvete sorveteManga = new Sorvete();
            sorveteManga.SaborSorvete = Sorveteria.Enums.SaborSorvete.MANGA;
            sorvetes.Add(sorveteManga);
            break;
        case 17:
            Console.WriteLine("Você selecionou o sabor Maracujá");
            Sorvete sorveteMaracuja = new Sorvete();
            sorveteMaracuja.SaborSorvete = Sorveteria.Enums.SaborSorvete.MARACUJÁ;
            sorvetes.Add(sorveteMaracuja);
            break;
        default:
            Console.WriteLine("Sabor de sorvete inválido, tente novamente outro sabor");
            break;
    }
    Console.WriteLine("\nDeseja colocar outro sabor?\nPara continuar digite Sim\nPara continuar apenas pressione enter");
    string continuarr = Console.ReadLine();
    continuar = continuarr.ToUpper();
}

Console.WriteLine("Os sabores que foram selecionados foram\n");

foreach (Sorvete sorvete in sorvetes)
{
    Console.WriteLine(sorvete.SaborSorvete.ToString());
}