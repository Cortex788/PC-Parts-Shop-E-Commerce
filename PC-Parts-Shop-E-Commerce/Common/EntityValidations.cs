using System.Drawing.Drawing2D;

namespace PC_Parts_Shop_E_Commerce.Common
{
    public static class EntityValidations
    {
        /* Category start */
        public const int CategoryNameMinLength = 2;
        public const int CategoryNameMaxLength = 60;

        /* Category end */


        /* Brand start */
        public const int BrandNameMinLength = 2;
        public const int BrandNameMaxLength = 60;
        /* Brand end */

        /* Product start */
         
        public const int ProductNameMinLength = 2;
        public const int ProductNameMaxLength = 150;

        public const int ProductDescriptionMinLength = 10;
        public const int ProductDescriptionMaxLength = 1000;

        public const int ProductPriceMinValue = 0;
        public const decimal ProductPriceMaxValue = decimal.MaxValue;
        /* Product end */

        /* GPU start */

        public const int GPUChipsetMinLength = 2;
        public const int GPUChipsetMaxLength = 150;
        public const int GPUVRAMMinValue = 1;
        public const int GPUVRAMMaxValue = 128;
        public const int GPUMemoryClockMinValue = 1;
        public const int GPUMemoryClockMaxValue = 100000;

        public const int GPULengthMinValue = 1;
        public const int GPULengthMaxValue = 1000;

        public const int GPUCoresMinValue = 1;
        public const int GPUCoresMaxValue = 10000;




        /* GPU end */

        /* CPU start */

        public const int CPUNameMinLength = 5;
        public const int CPUNameMaxLength = 100;
        public const int CPUCoresMinCount = 1;
        public const int CPUCoresMaxCount = 256;
        public const int CPUThreadsMinCount = 1;
        public const int CPUThreadsMaxCount = 512;
        public const int CPUBaseClockMinValue = 1;
        public const int CPUBaseClockMaxValue = 10000;
        public const int CPUBoostClockMinValue = 1;
        public const int CPUBoostClockMaxValue = 10000;



        /* CPU end */

        /* RAM start */
        public const int RAMCapacityMinValue = 1;
        public const int RAMCapacityMaxValue = 1024;
        public const int RAMMemorySpeedMinValue = 1;
        public const int RAMMemorySpeedMaxValue = 10000;
        /*RAM end*/

        /* Motherboard start */

        public const int MotherboardNameMinLength = 2;
        public const int MotherboardNameMaxLength = 100;

        public const int MotherboardChipsetMinLength = 2;
        public const int MotherboardChipsetMaxLength = 20;

        public const int MotherboardSocketMinLength = 2;
        public const int MotherboardSocketMaxLength = 15;

        public const int MotherboardMemorySlotsMinValue = 1;
        public const int MotherboardMemorySlotsMaxValue = 8;

        /* Motherboard end */


    }
}
