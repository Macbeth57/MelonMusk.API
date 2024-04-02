﻿using clickelon.api.DTO.Requests;
using clickelon.api.DTO.Responses;
using clickelon.api.Model;
using FastEndpoints;

namespace clickelon.api.EndPoints
{
    public class GetAPlayerByIdEndPoint : Endpoint<GetPlayerByIdRequestDTO, GetPlayerByIdResponseDTO>
    {
        public override void Configure()
        {
            Get("/GetPlayerById");
            AllowAnonymous();
        }
        public override async Task HandleAsync(GetPlayerByIdRequestDTO request, CancellationToken ct)
        {
            Player player = Player.GetAPlayerById(request.Id);

            await SendAsync(new()
            {
                Name = player.Name
            });
        }
    }
}