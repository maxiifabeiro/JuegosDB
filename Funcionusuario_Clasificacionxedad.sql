CREATE FUNCTION FN_ClasificacionEdadTexto (
    @IDClasificacionEdad INT
)
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @Resultado VARCHAR(50);

    SET @Resultado =
        CASE @IDClasificacionEdad
            WHEN 1 THEN 'ATP - Todo público'
            WHEN 2 THEN '+7 años'
            WHEN 3 THEN '+13 años'
            WHEN 4 THEN '+16 años'
            WHEN 5 THEN '+18 años'
            ELSE 'Desconocida'
        END;

    RETURN @Resultado;
END;
