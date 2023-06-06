using System.Collections.Generic;
namespace tp5.Models;

static class Escape
{
    private static string[] solucionesSalas;
    private static int estadoJuego=1;
    private static void InicializarJuego(){
        solucionesSalas=new string[]{"RLRO","SMARIRTS","KMMGZBPB","FABBIANI"};
    }
    public static int GetEstadoJuego(){
        return estadoJuego;
    }
    public static bool ResolverSala(int numSala,string respuesta){
        bool correcto=solucionesSalas[numSala]==respuesta;
        return correcto;
    }

}