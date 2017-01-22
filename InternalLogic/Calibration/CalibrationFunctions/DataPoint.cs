﻿namespace InternalLogicCalibration
{
    public class DataPoint
    {
        public readonly double mz;
        public readonly double rt;
        public readonly int msnOrder;
        public readonly double intensity;
        public readonly int selectedIonGuessChargeStateGuess;
        public readonly double isolationMZ;
        public readonly double totalIonCurrent;
        public readonly double injectionTime;
        public readonly double relativeMZ;

        public DataPoint(double mz, double rt, int msnOrder, double intensity, double totalIonCurrent, double injectionTime, int selectedIonGuessChargeStateGuess, double isolationMZ, double relativeMZ)
			:this(mz,  rt,  msnOrder,  intensity,  totalIonCurrent,  injectionTime)
		{
			this.selectedIonGuessChargeStateGuess = selectedIonGuessChargeStateGuess;
			this.isolationMZ = isolationMZ;
			this.relativeMZ = relativeMZ;
		}
        public DataPoint(double mz, double rt, int msnOrder, double intensity, double totalIonCurrent, double injectionTime)
        {
            this.mz = mz;
            this.rt = rt;
            this.msnOrder = msnOrder;
            this.intensity = intensity;
            this.totalIonCurrent = totalIonCurrent;
            this.injectionTime = injectionTime;
        }

        public override string ToString()
        {
            return "(" + mz + "," + rt + ")";
        }
    }
}