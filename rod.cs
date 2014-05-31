
singleton TSShapeConstructor(RodDae)
{
   baseShape = "./rod.dae";
   loadLights = "0";
};

function RodDae::onLoad(%this)
{
   %this.setMeshSize("colA2 2", "-2");
   %this.setMeshSize("colA1 2", "-1");
   %this.setMeshSize("Cold2 2", "-2");
   %this.setMeshSize("Colb2 2", "-2");
   %this.setMeshSize("Colc2 2", "-2");
   %this.setMeshSize("Colb1 2", "-1");
   %this.renameSequence("ambient", "root");
   %this.addSequence("root", "deploy", "0", "25", "1", "0");
   %this.setSequenceCyclic("deploy", "0");
   %this.addSequence("root", "ambient", "26", "38", "1", "0");
}
