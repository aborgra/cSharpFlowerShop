namespace FlowerShop {
  public interface IMothersDay {
    // states the requirements of the classes to be part of the interface
    // has no logic and doesn't implement, just states rules
    // should be favored when grouping objects together
    // can reference inherited properties
    double StemLength { get; set; }
  }
}