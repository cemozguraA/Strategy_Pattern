// See https://aka.ms/new-console-template for more information
using Strategy_Pattern;
using Strategy_Pattern.Movements;

var monster = new Monster();
monster.setMovemntType(new Fly());
monster.setMovemntType(new Walk());
