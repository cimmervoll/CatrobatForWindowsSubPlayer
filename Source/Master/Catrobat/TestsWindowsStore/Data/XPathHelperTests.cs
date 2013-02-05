﻿using System;
using Catrobat.Core.Misc.Helpers;
using Catrobat.Core.Objects;
using Catrobat.Core.Objects.Bricks;
using Catrobat.Core.Objects.Costumes;
using Catrobat.Core.Objects.Sounds;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace TestsWindowsStore.Data
{
  [TestClass]
  public class XPathHelperTests
  {
    [TestMethod]
    public void GetCostumeTest()
    {
      throw new NotImplementedException("Fix changed names");
      //var project = SampleLoader.LoadSampleXML("ultimateTest");
      
      //var sprite1 = project.SpriteList.Sprites[0] as Sprite;

      //var setCostumeBrick1 = sprite1.ScriptList.Scripts[0].BrickList.Bricks[12] as SetCostumeBrick;
      //Assert.AreEqual(XPathHelper.getElement(setCostumeBrick1.CostumeReference.Reference, sprite1), sprite1.CostumeList.Costumes[0]);
    }

    [TestMethod]
    public void GetSoundInfoTest()
    {
      throw new NotImplementedException("Fix changed names");
      //var project = SampleLoader.LoadSampleXML("ultimateTest");

      //var sprite2 = project.SpriteList.Sprites[1] as Sprite;

      //var playSoundBrick1 = sprite2.ScriptList.Scripts[0].BrickList.Bricks[0] as PlaySoundBrick;
      //Assert.AreEqual(XPathHelper.getElement(playSoundBrick1.SoundReference.Reference, sprite2), sprite2.SoundList.Sounds[0]);

      //var playSoundBrick2 = sprite2.ScriptList.Scripts[0].BrickList.Bricks[1] as PlaySoundBrick;
      //Assert.AreEqual(XPathHelper.getElement(playSoundBrick2.SoundReference.Reference, sprite2), sprite2.SoundList.Sounds[0]);

      //var playSoundBrick3 = sprite2.ScriptList.Scripts[0].BrickList.Bricks[2] as PlaySoundBrick;
      //Assert.AreEqual(XPathHelper.getElement(playSoundBrick3.SoundReference.Reference, sprite2), sprite2.SoundList.Sounds[1]);
    }

    [TestMethod]
    public void GetSpriteTest()
    {
      throw new NotImplementedException("Fix changed names");
      //var project = SampleLoader.LoadSampleXML("ultimateTest");

      //var sprite1 = project.SpriteList.Sprites[0] as Sprite;
      //var sprite2 = project.SpriteList.Sprites[1] as Sprite;
      //var sprite3 = project.SpriteList.Sprites[2] as Sprite;

      //var pointToBrick1 = sprite1.ScriptList.Scripts[0].BrickList.Bricks[10] as PointToBrick;
      //Assert.AreEqual(XPathHelper.getElement(pointToBrick1.PointedSpriteReference.Reference, sprite1), sprite2);

      //var pointToBrick2 = sprite2.ScriptList.Scripts[1].BrickList.Bricks[1] as PointToBrick;
      //Assert.AreEqual(XPathHelper.getElement(pointToBrick2.PointedSpriteReference.Reference, sprite2), sprite1);

      //var pointToBrick3 = sprite3.ScriptList.Scripts[0].BrickList.Bricks[1] as PointToBrick;
      //Assert.AreEqual(XPathHelper.getElement(pointToBrick3.PointedSpriteReference.Reference, sprite3), sprite2);
    }

    [TestMethod]
    public void GetLoopBeginTest()
    {
      throw new NotImplementedException("Fix changed names");
      //var project = SampleLoader.LoadSampleXML("ultimateTest");

      //var sprite2 = project.SpriteList.Sprites[1] as Sprite;
      //ReadHelper.currentBrickList = sprite2.ScriptList.Scripts[2].BrickList;

      //var foreverBrick = sprite2.ScriptList.Scripts[2].BrickList.Bricks[0] as ForeverBrick;
      //Assert.AreEqual(XPathHelper.getElement(foreverBrick.LoopEndBrickReference.Reference, sprite2), sprite2.ScriptList.Scripts[2].BrickList.Bricks[3]);

      //var repeatBrick = sprite2.ScriptList.Scripts[2].BrickList.Bricks[1] as RepeatBrick;
      //Assert.AreEqual(XPathHelper.getElement(repeatBrick.LoopEndBrickReference.Reference, sprite2), sprite2.ScriptList.Scripts[2].BrickList.Bricks[5]);
    }

    [TestMethod]
    public void GetLoopEndTest()
    {
      throw new NotImplementedException("Fix changed names");
      //var project = SampleLoader.LoadSampleXML("ultimateTest");

      //var sprite2 = project.SpriteList.Sprites[1] as Sprite;
      //ReadHelper.currentBrickList = sprite2.ScriptList.Scripts[2].BrickList;

      //var loopEndBrick1 = sprite2.ScriptList.Scripts[2].BrickList.Bricks[3] as LoopEndBrick;
      //Assert.AreEqual(XPathHelper.getElement(loopEndBrick1.LoopBeginBrickReference.Reference, sprite2), sprite2.ScriptList.Scripts[2].BrickList.Bricks[0]);

      //var loopEndBrick2 = sprite2.ScriptList.Scripts[2].BrickList.Bricks[5] as LoopEndBrick;
      //Assert.AreEqual(XPathHelper.getElement(loopEndBrick2.LoopBeginBrickReference.Reference, sprite2), sprite2.ScriptList.Scripts[2].BrickList.Bricks[1]);
    }

    [TestMethod]
    public void GetReferenceTest()
    {
      throw new NotImplementedException("Fix changed names");
      //var project = SampleLoader.LoadSampleXML("ultimateTest");

      //var sprite1 = project.SpriteList.Sprites[0] as Sprite;
      //var sprite2 = project.SpriteList.Sprites[1] as Sprite;
      //var sprite3 = project.SpriteList.Sprites[2] as Sprite;

      //var costume = (sprite1.ScriptList.Scripts[0].BrickList.Bricks[12] as SetCostumeBrick).Costume as Costume;
      //Assert.AreEqual(XPathHelper.getReference(costume, sprite1), "../../../../../costumeDataList/costumeData");

      //var soundInfo1 = (sprite2.ScriptList.Scripts[0].BrickList.Bricks[0] as PlaySoundBrick).Sound as Sound;
      //Assert.AreEqual(XPathHelper.getReference(soundInfo1,sprite2), "../../../../../soundList/soundInfo");

      //var soundInfo2 = (sprite2.ScriptList.Scripts[0].BrickList.Bricks[2] as PlaySoundBrick).Sound as Sound;
      //Assert.AreEqual(XPathHelper.getReference(soundInfo2, sprite2), "../../../../../soundList/soundInfo[2]");


      //Assert.AreEqual(XPathHelper.getReference(sprite2, sprite1), "../../../../../../sprite[2]");

      //Assert.AreEqual(XPathHelper.getReference(sprite1, sprite2), "../../../../../../sprite");

      //Assert.AreEqual(XPathHelper.getReference(sprite2, sprite3), "../../../../../../sprite[2]");

      //var loopEndBrick1 = (sprite2.ScriptList.Scripts[2].BrickList.Bricks[0] as ForeverBrick).LoopEndBrick as LoopEndBrick;
      //Assert.AreEqual(XPathHelper.getReference(loopEndBrick1, sprite2), "../../loopEndBrick");

      //var loopEndBrick2 = (sprite2.ScriptList.Scripts[2].BrickList.Bricks[1] as RepeatBrick).LoopEndBrick as LoopEndBrick;
      //Assert.AreEqual(XPathHelper.getReference(loopEndBrick2, sprite2), "../../loopEndBrick[2]");

      //var loopBeginBrick1 = (sprite2.ScriptList.Scripts[2].BrickList.Bricks[3] as LoopEndBrick).LoopBeginBrick as LoopBeginBrick;
      //Assert.AreEqual(XPathHelper.getReference(loopBeginBrick1, sprite2), "../../foreverBrick");

      //var loopBeginBrick2 = (sprite2.ScriptList.Scripts[2].BrickList.Bricks[5] as LoopEndBrick).LoopBeginBrick as LoopBeginBrick;
      //Assert.AreEqual(XPathHelper.getReference(loopBeginBrick2, sprite2), "../../repeatBrick");
    }
  }
}