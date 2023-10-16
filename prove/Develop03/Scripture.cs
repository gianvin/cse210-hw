using System;
using System.Collections.Generic;
using System.Text;

class Scripture
{
    private Random random;
    private Reference reference;
    private List<Word> verse;

    public Scripture(string scripture, Reference reference)
    {
        random = new Random();
        this.reference = reference;
    }
}