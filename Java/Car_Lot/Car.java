package Lab5.q1;

/**
Author : Todd Pidgeon
Date : 23/10/2016
Description : Defines the car class.
**/

public class Car {

    // Declair attributes of the person object.
    private String make;
    private String model;
    private int year;
    private Person owner;
   
    // Create constructors.
    public Car() {
        this.make = "NOT SPECIFIED";
        this.model = "NOT SPECIFIED";
        this.year = 0;
    } 
   
    public Car(String make, String model, int year) {
        this.make = make;
        this.model = model;
        this.year = year;
    }
    
    public Car(String make, String model, int year, Person owner) {
        this.make = make;
        this.model = model;
        this.year = year;
        this.owner = owner;
    }
    
    // Create setters and getters for all attributes.
    /**
     * @return the make
     */
    public String getMake() {
        return make;
    }

    /**
     * @param make the make to set
     */
    public void setMake(String make) {
        this.make = make;
    }
    
    /**
     * @return the model
     */
    public String getModel() {
        return model;
    }

    /**
     * @param model the model to set
     */
    public void setModel(String model) {
        this.model = model;
    }
    
    /**
     * @return the year
     */
    public int getYear() {
        return year;
    }

    /**
     * @param year the year to set
     */
    public void setYear(int year) {
        this.year = year;
    }
    
    /**
     * @return the owner
     */
    public Person getOwner() {
        return owner;
    }

    /**
     * @param owner the owner to set
     */
    public void setOwner(Person owner) {
        this.owner = owner;
    }
    
    // A ToString override which also accounts for no owner being set. If there
    //  is no owner it will not print one for the car lot list.
    @Override
    public String toString() {
        if (getOwner() == null){
            return "Make : " + getMake() + "\n"
            + "Model : " + getModel() + "\n"
            + "Year : " + getYear() + "\n";
        }
        else{
        return "Make : " + getMake() + "\n"
            + "Model : " + getModel() + "\n"
            + "Year : " + getYear() + "\n"
            + "Owner : " + getOwner() + "\n";
        }
    }
    
    // A eguals override.
    @Override
    public boolean equals(Object obj) {
        if (!(obj instanceof Car)) {
            return false;
        }
        Car i = (Car) obj;
        if (make.equals(i.getMake())
                && model.equals(i.getModel())) {
            return true;
        }
        
        return false;
    }   
}