using System;
using System.Collections.Generic;

public static class PesoLettere
{

    public static int Pesa(string input)
    {
       int len = input.Length;
        int peso=0;
        string alfabeto = "abcdefghijklmnopqrstuvwxyz";
        int [] pesi = new int[]{1,3,3,2,1,4,2,4,1,8,5,1,3,1,1,3,10,1,1,1,1,4,4,8,4,10};
        for( int idx=0 ; idx<len ; idx++){

        
            peso += pesi[alfabeto.IndexOf(input.ToLower()[idx])];
        }
        return peso;

    
    }
}