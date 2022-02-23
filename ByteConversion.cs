using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStorageUnitConverter
{
    public class ByteConversion
    {
        private readonly int _conversionValue;

        public ByteConversion()
        {
            _conversionValue = 1;
        }

        public ByteConversion(int inputValue)
        {
            _conversionValue = inputValue;

        }

        public int ConvertMegabytesToBytes()
        {
            int megabytesToBytes = _conversionValue * 1048576;
            return megabytesToBytes;
        }

        public int ConvertGigabytesToMegabyte()
        {
            int gigabytesToMegabyte = _conversionValue * 1024;
            return gigabytesToMegabyte;
        }

        public int ConvertTerabytetoGigabytes()
        {
            int terabyteToGigabyte = _conversionValue * 1024;
            return terabyteToGigabyte;
        }

    }
}
