singleton Material(steamthing1_metal3)
{
   mapTo = "metal3";
   diffuseColor[0] = "0.5 0.5 0.5 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "128";
   doubleSided = "1";
   translucentBlendOp = "None";
   specularStrength[0] = "5";
   pixelSpecular[0] = "1";
   diffuseMap[0] = "art/shapes/buildings/cityscape/steamthing1.png";
};

singleton Material(steamthing1_steamthingReadout1)
{
   mapTo = "steamthingReadout1";
   diffuseColor[0] = "0.64 0.64 0.64 1";
   specular[0] = "0.5 0.5 0.5 1";
   specularPower[0] = "50";
   doubleSided = "1";
   translucentBlendOp = "None";
   diffuseMap[0] = "art/shapes/buildings/cityscape/steamthing_readout.DDS";
   animFlags[0] = "0x00000010";
   rotSpeed[0] = "0.5";
   rotPivotOffset[0] = "-0.53 -0.5";
   specularStrength[0] = "1.25";
   glow[0] = "1";
   emissive[0] = "1";
   waveFreq[0] = "0.1";
   waveAmp[0] = "1";
   sequenceFramePerSec[0] = "2";
   sequenceSegmentSize[0] = "0.03125";
};