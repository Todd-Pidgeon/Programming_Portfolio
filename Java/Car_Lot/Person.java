package Lab5.q1;

/**
Author : Todd Pidgeon
Date : 23/10/2016
Description : Defines the person class
**/

public class Person {

    // Declair attributes of the person object.
    private String firstname;
    private String lastname;
    
    public Person(){
        this.firstname = "NOT";
        this.lastname = "SET";
    }
    
    // Create constructors.
    public Person(String firstname, String lastname){
        this.firstname = firstname;
        this.lastname = lastname;
    }
      
     // Create setters and getters for all attributes.
    /**
     * @return the firstname
     */
    public String getFirstname() {
        return firstname;
    }

    /**
     * @param firstname the firstname to set
     */
    public void setFirstname(String firstname) {
        this.firstname = firstname;
    }

    /**
     * @return the lastname
     */
    public String getLastname() {
        return lastname;
    }

    /**
     * @param lastname the lastname to set
     */
    public void setLastname(String lastname) {
        this.lastname = lastname;
    } 
    
    // A ToString override
    @Override
    public String toString() {
        return getFirstname() + " " + getLastname() + "\n";
    }
    
    // A eguals override.
    @Override
    public boolean equals(Object obj) {
        if (!(obj instanceof Person)) {
            return false;
        }
       Person p = (Person) obj;
        if (firstname.equals(p.getFirstname())
                && lastname.equals(p.getLastname())) {
            return true;
        }
        
        return false;
    }
}