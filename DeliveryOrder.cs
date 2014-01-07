using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IT151PizzaOrders
{
    class DeliveryOrder
    {
        public DeliveryOrder()
        {
        }

        public DeliveryOrder(String sAdd, Int32 iSz,
            Boolean bXChs, Boolean bGrnBf, Boolean bItal, Boolean bPeprni,
            Boolean bCanBac, Boolean bOnions, Boolean bGrnPep, Boolean bBlkOlv,
            Boolean bGrnOlv, Boolean bShrooms)
        {
            sAddress = sAdd;
            iSize = iSz;
            bExtCheese = bXChs;
            bGround = bGrnBf;
            bItaln = bItal;
            bPepperoni = bPeprni;
            bCanadian = bCanBac;
            bOnion = bOnions;
            bGreen = bGrnPep;
            bBlack = bBlkOlv;
            bOlives = bGrnOlv;
            bMushrooms = bShrooms;
        }

        public String GetAddress()
        {
            return sAddress;
        }

        public Int32 GetSize()
        {
            return iSize;
        }

        public Boolean IsXch()
        {
            return bExtCheese;
        }

        public Boolean IsGrndBeef()
        {
            return bGround;
        }

        public Boolean IsItalian()
        {
            return bItaln;
        }

        public Boolean IsPep()
        {
            return bPepperoni;
        }

        public Boolean IsCanadian()
        {
            return bCanadian;
        }

        public Boolean IsOnions()
        {
            return bOnion;
        }

        public Boolean IsGreenPep()
        {
            return bGreen;
        }

        public Boolean IsBlack()
        {
            return bBlack;
        }

        public Boolean IsGreen()
        {
            return bGreen;
        }

        public Boolean IsBlkOlvs()
        {
            return bBlack;
        }

        public Boolean IsGrnOlvs()
        {
            return bOlives;
        }

        public Boolean IsShrooms()
        {
            return bMushrooms;
        }

        String sAddress;
        Int32 iSize;
        Boolean bExtCheese;
        Boolean bGround;
        Boolean bItaln;
        Boolean bPepperoni;
        Boolean bCanadian;
        Boolean bOnion;
        Boolean bGreen;
        Boolean bBlack;
        Boolean bOlives;
        Boolean bMushrooms;
    }
}
