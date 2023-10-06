using Sorveteria.Entities;
using System.Collections.Generic;

List<Sorvete> sorvetes = new List<Sorvete>();
string continuar = "SIM";
decimal precofinal = 0;

while (continuar == "SIM")
{
    Console.WriteLine("\nBem vindos a Sorveteria do Tio Anastácio\n\nQuais sabores você deseja:\n\n1.MORANGO,\n2.BAUNILHA,\n3.CHOCOLATE,\n4.CARAMELO,\n5.AMÊNDOA,\n6.COCO,\n7.MENTA,\n8.LIMÃO,\n9.FRAMBOESA,\n10.ABACAXI,\n11.PISTACHE,\n12.AMORA,\n13.FLOCOS,\n14.PÊSSEGO,\n15.Amendoim,\n16.MANGA,\n17.MARACUJÁ\n\nCada Sorvete escolhido é 1 real");
    Console.WriteLine("\nDigie o Numero do Sabor que deseja");
    int saborSorvete = Convert.ToInt32(Console.ReadLine());
    switch (saborSorvete)
    {
        case 1:
            Console.WriteLine("Você selecionou o sabor Morango");
            Sorvete sorveteMorango = new Sorvete();
            sorveteMorango.SaborSorvete = Sorveteria.Enums.SaborSorvete.Morango;
            sorvetes.Add(sorveteMorango);
            precofinal = precofinal + 1;
                break;
        case 2:
            Console.WriteLine("Você selecionou o sabor Baunilha");
            Sorvete sorveteBaunilha = new Sorvete();
            sorveteBaunilha.SaborSorvete = Sorveteria.Enums.SaborSorvete.Baunilha;
            sorvetes.Add(sorveteBaunilha);
            precofinal = precofinal + 1;
            break;
        case 3:
            Console.WriteLine("Você selecionou o sabor Chocolate");
            Sorvete sorveteChocolate = new Sorvete();
            sorveteChocolate.SaborSorvete = Sorveteria.Enums.SaborSorvete.Chocolate;
            sorvetes.Add(sorveteChocolate);
            precofinal = precofinal + 1; break;
        case 4:
            Console.WriteLine("Você selecionou o sabor Caramelo");
            Sorvete sorveteCaramelo = new Sorvete();
            sorveteCaramelo.SaborSorvete = Sorveteria.Enums.SaborSorvete.Caramelo;
            sorvetes.Add(sorveteCaramelo);
            precofinal = precofinal + 1;
            break;
        case 5:
            Console.WriteLine("Você selecionou o sabor Amêndoa");
            Sorvete sorveteAmendoa = new Sorvete();
            sorveteAmendoa.SaborSorvete = Sorveteria.Enums.SaborSorvete.Amêndoa;
            sorvetes.Add(sorveteAmendoa);
            precofinal = precofinal + 1;
            break;
        case 6:
            Console.WriteLine("Você selecionou o sabor Coco");
            Sorvete sorveteCoco = new Sorvete();
            sorveteCoco.SaborSorvete = Sorveteria.Enums.SaborSorvete.Coco;
            sorvetes.Add(sorveteCoco);
            precofinal = precofinal + 1;
            break;
        case 7:
            Console.WriteLine("Você selecionou o sabor Menta");
            Sorvete sorveteMenta = new Sorvete();
            sorveteMenta.SaborSorvete = Sorveteria.Enums.SaborSorvete.Menta;
            sorvetes.Add(sorveteMenta);
            precofinal = precofinal + 1;
            break;
        case 8:
            Console.WriteLine("Você selecionou o sabor Limão");
            Sorvete sorveteLimao = new Sorvete();
            sorveteLimao.SaborSorvete = Sorveteria.Enums.SaborSorvete.Limão;
            sorvetes.Add(sorveteLimao);
            precofinal = precofinal + 1;
            break;
        case 9:
            Console.WriteLine("Você selecionou o sabor Framboesa");
            Sorvete sorveteFramboesa = new Sorvete();
            sorveteFramboesa.SaborSorvete = Sorveteria.Enums.SaborSorvete.Framboesa;
            sorvetes.Add(sorveteFramboesa);
            precofinal = precofinal + 1;
            break;
        case 10:
            Console.WriteLine("Você selecionou o sabor Abacaxi");
            Sorvete sorveteAbacaxi = new Sorvete();
            sorveteAbacaxi.SaborSorvete = Sorveteria.Enums.SaborSorvete.Abacaxi;
            sorvetes.Add(sorveteAbacaxi);
            precofinal = precofinal + 1;
            break;
        case 11:
            Console.WriteLine("Você selecionou o sabor Pistache");
            Sorvete sorvetePistache = new Sorvete();
            sorvetePistache.SaborSorvete = Sorveteria.Enums.SaborSorvete.Pistache;
            sorvetes.Add(sorvetePistache);
            precofinal = precofinal + 1;
            break;
        case 12:
            Console.WriteLine("Você selecionou o sabor Amora");
            Sorvete sorveteAmora = new Sorvete();
            sorveteAmora.SaborSorvete = Sorveteria.Enums.SaborSorvete.Amendoim;
            sorvetes.Add(sorveteAmora);
            precofinal = precofinal + 1;
            break;
        case 13:
            Console.WriteLine("Você selecionou o sabor Flocos");
            Sorvete sorveteFlocos = new Sorvete();
            sorveteFlocos.SaborSorvete = Sorveteria.Enums.SaborSorvete.Flocos;
            sorvetes.Add(sorveteFlocos);
            precofinal = precofinal + 1;
            break;
        case 14:
            Console.WriteLine("Você selecionou o sabor Pêssego");
            Sorvete sorvetePessego = new Sorvete();
            sorvetePessego.SaborSorvete = Sorveteria.Enums.SaborSorvete.Pêssego;
            sorvetes.Add(sorvetePessego);
            precofinal = precofinal + 1;
            break;
        case 15:
            Console.WriteLine("Você selecionou o sabor Amendoim");
            Sorvete sorveteAmendoim = new Sorvete();
            sorveteAmendoim.SaborSorvete = Sorveteria.Enums.SaborSorvete.Amendoim;
            sorvetes.Add(sorveteAmendoim);
            precofinal = precofinal + 1;
            break;
        case 16:
            Console.WriteLine("Você selecionou o sabor Manga");
            Sorvete sorveteManga = new Sorvete();
            sorveteManga.SaborSorvete = Sorveteria.Enums.SaborSorvete.Manga;
            sorvetes.Add(sorveteManga);
            precofinal = precofinal + 1;
            break;
        case 17:
            Console.WriteLine("Você selecionou o sabor Maracujá");
            Sorvete sorveteMaracuja = new Sorvete();
            sorveteMaracuja.SaborSorvete = Sorveteria.Enums.SaborSorvete.Maracuja;
            sorvetes.Add(sorveteMaracuja);
            precofinal = precofinal + 1;
            break;
        default:
            Console.WriteLine("Sabor de sorvete inválido, tente novamente outro sabor");
            break;
    }
    Console.WriteLine("\nDeseja colocar outro sabor?\nPara continuar digite Sim\nPara terminar apenas pressione enter");
    string continuarr = Console.ReadLine();
    continuar = continuarr.ToUpper();
}

Console.WriteLine("Os sabores que foram selecionados foram\n");

foreach (Sorvete sorvete in sorvetes)
{
    Console.WriteLine(sorvete.SaborSorvete.ToString());
}
Console.WriteLine($"\nValor Total:{precofinal} R$");