using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TInt, TString>
    {
        TInt[] _tInt;
        TString[] _tString;

        public MyDictionary()
        {
            _tInt = new TInt[0];
            _tString = new TString[0];
        }

        public void Add(TInt tInt, TString tString)
        {
            TInt[] tempArrayKeys = _tInt;
            TString[] tempArrayValue = _tString;

            _tInt = new TInt[_tInt.Length + 1];
            _tString = new TString[_tString.Length + 1];

            for (int i = 0; i < tempArrayKeys.Length; i++)
            {
                _tInt[i] = tempArrayKeys[i];
            }

            for (int i = 0; i < tempArrayValue.Length; i++)
            {
                _tString[i] = tempArrayValue[i];
            }

            _tInt[_tInt.Length - 1] = tInt;
            _tString[_tString.Length - 1] = tString;

            Console.WriteLine("Numara: " + tInt + " Ad: " + tString);
        }
    }
}