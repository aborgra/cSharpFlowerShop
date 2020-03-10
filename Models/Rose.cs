namespace FlowerShop {
  public class Rose : IMothersDay {
    // class-based polymorphism - object has many types (Rose, IMothersDay) done with inheritance or interfaces
    public string Color { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Cost { get; set; }
    public string Water { get; set; }
    public bool Thorny { get; set; }
    public bool Fragrant { get; set; }
    public double StemLength { get; set; }
  }
}