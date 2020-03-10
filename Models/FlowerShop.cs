using System.Collections.Generic;

namespace FlowerShop {
  public class FlowerShop {
    List<Rose> RoseList = new List<Rose> ();
    List<Tulip> TulipList = new List<Tulip> ();

    List<Sunflower> SunflowerList = new List<Sunflower> ();

    List<Carnation> CarnationList = new List<Carnation> ();

    public List<IMothersDay> MakeMothersDayArr () {
      List<IMothersDay> MothersDayArr = new List<IMothersDay> ();
      MothersDayArr.Add (new Rose ());
      MothersDayArr.Add (new Rose ());
      MothersDayArr.Add (new Carnation ());
      MothersDayArr.Add (new Carnation ());

      return MothersDayArr;
    }

    public List<IBirthday> MakeBirthdayArr () {
      List<IBirthday> BirthdayArr = new List<IBirthday> ();
      BirthdayArr.Add (new Sunflower ());
      BirthdayArr.Add (new Sunflower ());
      BirthdayArr.Add (new Tulip ());
      BirthdayArr.Add (new Tulip ());

      return BirthdayArr;
    }

    public List<IGetWell> MakeGetWellArr () {
      List<IGetWell> GetWellArr = new List<IGetWell> ();
      GetWellArr.Add (new Fern ());
      GetWellArr.Add (new Fern ());
      GetWellArr.Add (new Fern ());

      return GetWellArr;
    }

  }
}