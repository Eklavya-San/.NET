# Layered Architecture 
{

    __WEBSITE, BLL (BUISNESS LOGIC LAYER), BOL (BUISNESS OBJECT LAYER)  , DAL (DATA ACCESS LAYER)__

    >Website{
        -Configrations{

        }
        -Views{
            UI
        }
        -Controllers{
            Request,Response
        }
    }


    >BLL{
        -Buisness Logic
    }

    >BOL{
        -Entities {
            classes Containing entity blueprints
        }
    }

    >DAL{
        -DB-Manager-class{
            --CRUD operations
        }
    }

    >CLI
    >Libraries{
        -odbc(Open data base connectivity)
    }

    >RDBMS{
        -tables{
            
        }
        -stored-procedures{

        }
        -triggers{

        }

    }
    >Database engine 
        -DDL,DML,DCL,TCL

    
}