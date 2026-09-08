# DevFlow Architecture Sketch

                 Browser
                    |
                    |
                    v

              DevFlow API
                    |
        -------------------------
        |                       |
        v                       v

    Database              Future Mobile App


The browser and mobile application communicate with the same backend API.

The API handles business logic and communicates with the database to store users, boards, columns, and cards.